
using PFinanzas.Data.Context;

namespace PFinanzas.Data.Services
{
    public class PFinanzasServices
    {
        public class Result
        {
            public bool Success { get; set; }
            public string? Message { get; set; }

        }

        public class Result<T>
        {
            public bool Success { get; set; }
            public string? Message { get; set; }
            public T? Data { get; set; }

        }




        private readonly IMyDbContext dbContext;

        public PFinanzasServices(IMyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
