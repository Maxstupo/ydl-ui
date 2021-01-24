namespace Maxstupo.YdlUi.Controls {

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    public class DataGridViewProgressColumn : DataGridViewImageColumn {
        public DataGridViewProgressColumn() {
            CellTemplate = new DataGridViewProgressCell();
        }
    }

    public class DataGridViewProgressCell : DataGridViewImageCell {
        // Used to make custom cell consistent with a DataGridViewImageCell
        private static Image emptyImage;

        static DataGridViewProgressCell() {
            emptyImage = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        }

        public DataGridViewProgressCell() {
            this.ValueType = typeof(int);
        }

        // Method required to make the Progress Cell consistent with the default Image Cell. 
        // The default Image Cell assumes an Image as a value, although the value of the Progress Cell is an int.
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context) {
            return emptyImage;
        }

        protected override void Paint(Graphics g, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts) {
            try {
                int progressVal = (int) value;
                float percentage = (progressVal / 100.0f);

                // Draws the cell grid
                base.Paint(g, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, (paintParts & ~DataGridViewPaintParts.ContentForeground));

                // Draw the progress bar.
                float progressX = cellBounds.X + 2;
                float progressWidth = percentage * (cellBounds.Width - 4);
                using (Brush brush = new SolidBrush(Color.FromArgb(203, 235, 108)))
                    g.FillRectangle(brush, progressX, cellBounds.Y + 2, progressWidth, cellBounds.Height - 4);


                // Draw the progress label.
                string progressText = $"{progressVal}%";
                SizeF lblSize = g.MeasureString(progressText, cellStyle.Font);


                float lblX = progressX + ((cellBounds.Width - 4) / 2 - lblSize.Width / 2);
                float lblY = cellBounds.Y + 2;

                bool isSelectedRow = false;
                foreach (DataGridViewRow row in DataGridView.SelectedRows) {
                    if (row.Index == rowIndex) {
                        isSelectedRow = true;
                        break;
                    }
                }
                bool useSelectionColor = isSelectedRow && (progressX + progressWidth) < lblX; // Only use selection color, if row is selected and progress hasn't reached the progress label.

                using (Brush brush = new SolidBrush(useSelectionColor ? cellStyle.SelectionForeColor : cellStyle.ForeColor))
                    g.DrawString(progressText, cellStyle.Font, brush, lblX, lblY);

            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }

    }

}