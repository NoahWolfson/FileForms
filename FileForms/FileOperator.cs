using System.Data;

class FileOperator
{


	public static string ReadFileContents(string filePath)
	{
		Byte[] buffer = new Byte[4096];
		string FileContent = "";
		try
		{
			using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				int byteRead;
				while ((byteRead = fs.Read(buffer, 0, buffer.Length)) > 0)
				{
					string chunk = System.Text.Encoding.UTF8.GetString(buffer, 0, byteRead);
					FileContent += chunk;
				}
			}
			return FileContent;
		}
		catch
		{
			return "Error Recieveing File Content";
		}

	}
	public static void WriteToFile(string filePath, string lines)
	{
		File.AppendAllText(filePath, lines);
	}
}