namespace View.Insfractuture
{
    internal class HttpParameter
    {
        public HttpParameter(string id, string value)
        {
            this.Id = id;
            this.Value = value;
        }

        public string Id { get; init; }
        public string Value { get; init; }
    }
}