﻿
namespace Ustora.Core
{
    public interface IUnitOfWork : IDisposable
    {
        //IBaseRepository<Author> Authors { get; }
        //IBooksRepository Books { get; }

        int Complete();
    }
}