namespace Pulsar.Infrastructure.DataCollector.DataContexts
{
    public static class ContextObjects
    {
        public static Environment PulsarEnvironment;

        public static PulsarDataContext PulsarDataContext
        {
            get
            {
                return PulsarEnvironment == Environment.Local
                    ? new PulsarDataContext("PulsarLocal")
                    : new PulsarDataContext("PulsarAzure");
            }
        }
    }

    //TODO NICOLAS If the Build framework is implemented, add a config param to set the Environment and then check for it here
    // By Default set to Azure, unless Environment is set by implementation
    public enum Environment
    {
        Azure,
        Local
    };
}
