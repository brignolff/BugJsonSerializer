using Ardeje.Serialisation.Json;

namespace BugJsonSerializer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Config config = new Config();

			config.elem1.propA.PropertyB = config.elem2.propB;

			JsonSerializer jsonSerializer = new JsonSerializer();

			jsonSerializer.Sauvegarde(@"FichiersSerialise\test.ardcfg", config);

			var res = jsonSerializer.Charge<Config>(@"FichiersSerialise\test.ardcfg");
		}
	}
}