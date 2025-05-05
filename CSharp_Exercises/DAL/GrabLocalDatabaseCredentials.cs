using System;
using System.Text.Json;
using System.Runtime.InteropServices;


public class GrabLocalDatabaseCredentials
{
    private Dictionary<string, string>? localCredentials;
    public string sqlConnStr = "";
    private string sqlConnStr_Win = "";
    private string sqlConnStr_Mac = "";

    public GrabLocalDatabaseCredentials()
    {
        localCredentials = OpenLocalAuthFile();
        SetSQLString(localCredentials);
    }

    public Dictionary<string,string>? OpenLocalAuthFile()
	{
		Console.WriteLine("Attempting to grab DB credentials from local credentials.json...");
        string path = "";

        // Path depends on which computer I'm developing on
        path = "C:/Users/willi/Desktop/credentials.json";
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
		{
			path = @"/Users/williamprakash/Desktop/credentials.json";
		}

		// Grab credentials
		if (File.Exists(path))
		{
			string jsonToParse = File.ReadAllText(path);
			Dictionary<string,string>? dict = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonToParse);

			// If nothing was found in credentials.json, return an empty dictionary
			if (dict == null) { return new Dictionary<string, string> { { "", "" } }; };

			Console.WriteLine("DB credentials grabbed.");
            return dict;
		}
        else
        {
			Console.WriteLine("DB credentials not found.");
            Dictionary<string, string>? empty = new Dictionary<string, string>();
            return empty;
        }
	}

	public void SetSQLString(Dictionary<string, string>? creds)
	{
        // If no DB credentials are found, return
        if (creds == null || creds.Count == 0) { return; }

        for (int i = 0; i < creds.Keys.Count; i++)
        {
            switch (creds.ElementAt(i).Key)
            {
                case "SQLServer_Win":
                    sqlConnStr_Win = creds.ElementAt(i).Value;
                    break;
                case "SQLServer_Mac":
                    sqlConnStr_Mac = creds.ElementAt(i).Value;
                    break;
            }
        }

        // Set main SQL connection string based on the host OS
        sqlConnStr = sqlConnStr_Win;
        if (System.Environment.OSVersion.Platform == PlatformID.Unix)
        {
            sqlConnStr = sqlConnStr_Mac;
        }
    }
}


