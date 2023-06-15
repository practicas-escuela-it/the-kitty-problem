namespace TheKittyProblem {
    class Repository : IRepository
    {
        public Model get()
        {
            return new Model();
        }
    }
}