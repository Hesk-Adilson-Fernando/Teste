using System.Data;

namespace DMZ.UI.Reports
{
    public static class Rsql
    {
        internal static DataTable PrintInitialize()
        {
            var ds =new DS();
            return ds.Fact;
        }
    }
}
