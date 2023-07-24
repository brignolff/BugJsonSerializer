using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Ardeje.Serialisation.Json
{
	public class JsonSerializer
	{
		private readonly JsonSerializerSettings _settings = new()
		{
			TypeNameHandling = TypeNameHandling.All,
			ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
			PreserveReferencesHandling = PreserveReferencesHandling.All,
			MaxDepth = null
		};

		/// <inheritdoc/>
		public TObj? Charge<TObj>(string cheminFichier)
		{
			try
			{
				if (!File.Exists(cheminFichier))
				{
					Debug.Fail("");
					return default;
				}

				var lines = File.ReadAllText(cheminFichier);

				var state = JsonConvert.DeserializeObject<TObj>(lines, _settings);

				return state;
			}
			catch (Exception ex)
			{
				Debug.Fail("");
				return default;
			}
		}

		/// <inheritdoc/>
		public void Sauvegarde(string cheminFichier, object donnée)
		{
			if (string.IsNullOrWhiteSpace(cheminFichier))
			{
				Debug.Fail("");
			}
			else
			{
				try
				{
					Directory.CreateDirectory(Path.GetDirectoryName(cheminFichier)!);

					var lines = JsonConvert.SerializeObject(donnée, Formatting.Indented, _settings);

					File.WriteAllText(cheminFichier, lines);
				}
				catch (Exception ex)
				{
					Debug.Fail("");
				}
			}
		}
	}
}
