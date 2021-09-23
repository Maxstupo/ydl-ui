namespace Maxstupo.YdlUi.Core.Arguments {

    public interface IArgumentSerializer {

        string Serialize(object arguments);

    }

    public interface ICommandLineSerializer {

        string Serialize(string filename, object arguments);

    }

}