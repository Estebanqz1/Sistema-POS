namespace POS.Infrastructure.Commons.Bases
{
    public class BasePaginationRequest
    {
        #region Propiedades

        public int NumPage { get; set; } = 1;
        public int NumRecordsPage { get; set; } = 10;
        private readonly int NumMaxRecordsPage = 50;
        public string Order { get; set; } = "asc";
        public string? Sort { get; set; } = null;
        public int Records
        {
            get => NumRecordsPage;
            set
            {
                NumRecordsPage = (value > NumMaxRecordsPage) ? NumMaxRecordsPage : value;
            }
        }
        #endregion

        #region Constructror
        #endregion

        #region Metodos
        #endregion
    }
}
