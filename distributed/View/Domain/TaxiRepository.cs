using View.Insfractuture;

namespace View.Domain
{
    internal interface TaxipRepository
    {
        internal string BaseUri { get; }

        internal TResponse Get<TResponse>(string relativeRestUri, IList<HttpParameter> parameters = null);
        internal TResponse Get<TResponse, TRequest>(string relativeRestUri, TRequest item);

        internal TResponse Put<TResponse, TRequest>(string relativeRestUri, TRequest item);

        internal TResponse Post<TResponse, TRequest>(string relativeRestUri, TRequest item);
    }
}