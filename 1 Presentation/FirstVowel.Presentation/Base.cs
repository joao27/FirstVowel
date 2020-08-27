using FirstVowel.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FirstVowel.Presentation
{
    public abstract class Base
    {
        private static IServiceCollection _collection;

        protected static IServiceProvider Provider { get; private set; }

        protected static void RegisterServices()
        {
            _collection = new ServiceCollection();
            _collection.AddDomain();

            Provider = _collection.BuildServiceProvider();
        }

        protected static void Dispose()
        {
            if (Provider is IDisposable disposable)
                disposable.Dispose();
        }

    }
}
