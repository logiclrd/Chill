namespace Chill.StateBuilders
{
    public class StoreStateBuilder<T> : IStoreStateBuilder<T>
        where T: class
    {
        public StoreStateBuilder(TestBase testBase)
        {
            TestBase = testBase;
        }


        public virtual TestBase To(T valueToSet)
        {
            TestBase.ChillTestInitializer.Set(TestBase, valueToSet);
            return TestBase;
        }


        public TestBase TestBase { get; set; }
    }
}