using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;

namespace Maxstupo.YdlUi.Utility {

    public class SortableBindingList<T> : BindingList<T> {

        private bool isSorted;
        private ListSortDirection sortDirection;
        private PropertyDescriptor sortProperty;

        protected override bool IsSortedCore { get { return isSorted; } }
        protected override ListSortDirection SortDirectionCore { get { return sortDirection; } }
        protected override PropertyDescriptor SortPropertyCore { get { return sortProperty; } }
        protected override bool SupportsSortingCore { get { return true; } }

        public SortableBindingList(List<T> list) : base(list) {
        }

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction) {
            if (!PropertyComparer.CanSort(property.PropertyType))
                return;

            ((List<T>)Items).Sort(new PropertyComparer(property, direction));

            sortDirection = direction;
            sortProperty = property;
            isSorted = true;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }


        protected override void RemoveSortCore() {
            isSorted = false;
            sortProperty = null;
        }


        #region Comparer

        private class PropertyComparer : Comparer<T> {
            private readonly ListSortDirection direction;
            private readonly PropertyDescriptor property;

            private readonly IComparer comparer;
            private readonly bool useToString;

            public PropertyComparer(PropertyDescriptor property, ListSortDirection direction) {
                if (!property.ComponentType.IsAssignableFrom(typeof(T)))
                    throw new MissingMemberException(typeof(T).Name, property.Name);

                if (!CanSort(property.PropertyType))
                    throw new ArgumentException("Cannot use PropertyComparer unless it can be compared by IComparable or ToString.");

                this.property = property;
                this.direction = direction;

                if (CanSortWithIComparable(property.PropertyType)) {
                    PropertyInfo propertyInfo = typeof(Comparer<>).MakeGenericType(new[] { property.PropertyType }).GetTypeInfo().GetDeclaredProperty("Default");
                    comparer = (IComparer)propertyInfo.GetValue(null, null);
                    useToString = false;

                } else if (CanSortWithToString(property.PropertyType)) {
                    comparer = StringComparer.CurrentCultureIgnoreCase;
                    useToString = true;

                } else {
                    throw new ArgumentException("Cannot use PropertyComparer unless it can be compared by IComparable or ToString");

                }
            }

            public override int Compare(T left, T right) {
                object leftValue = property.GetValue(left);
                object rightValue = property.GetValue(right);

                if (useToString) {
                    leftValue = leftValue?.ToString();
                    rightValue = rightValue?.ToString();
                }

                return direction == ListSortDirection.Ascending
                           ? comparer.Compare(leftValue, rightValue)
                           : comparer.Compare(rightValue, leftValue);
            }

            public static bool CanSort(Type type) {
                return CanSortWithToString(type) || CanSortWithIComparable(type);
            }


            private static bool CanSortWithIComparable(Type type) {
                return type.GetInterface("IComparable") != null ||
                       (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>));
            }

            private static bool CanSortWithToString(Type type) {
                return type.Equals(typeof(XNode)) || type.IsSubclassOf(typeof(XNode));
            }
        }

        #endregion
    }
}
