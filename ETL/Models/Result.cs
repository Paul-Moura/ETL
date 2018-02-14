namespace ETL.Models
{
    public sealed class Result
    {
        public bool Success { get; }

        public int TableCount { get; }

        public int TotalRows { get; }

        public int ValidRows { get; }

        public int FlaggedRows { get; }

        public int RemovedRows { get; }

        public Result()
        {
            this.Success = false;
        }

        public Result(int tableCount, int totalRows) : this(tableCount, totalRows, 0, 0, 0)
        {
        }

        public Result(int tableCount, int totalRows, int validRows, int flaggedRows, int removedRows)
        {
            this.Success = true;
            this.TableCount = tableCount;
            this.TotalRows = totalRows;
            this.ValidRows = validRows;
            this.FlaggedRows = flaggedRows;
            this.RemovedRows = removedRows;
        }
    }
}
