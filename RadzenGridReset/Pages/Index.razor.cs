using Microsoft.AspNetCore.Components;
using RadzenGridReset.Models;

namespace RadzenGridReset.Pages;

public partial class Index : ComponentBase
{
	private List<Model> Data { get; set; } = new();

	protected override void OnInitialized()
	{
		for (int i = 0; i < 20; i++)
		{
			Data.Add(new Model
			{
				Name = RandomString(10),
				Number = Random.Shared.Next()
			});
		}
	}

	private static string RandomString(int length)
	{
		const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		return new string(Enumerable.Repeat(chars, length)
			.Select(s => s[Random.Shared.Next(s.Length)]).ToArray());
	}
}