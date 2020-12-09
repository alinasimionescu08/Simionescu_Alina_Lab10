using SQLite;
using System;

public class Simionescu_Alina_Lab10.Models
{
	public class ShopList
	{
	[PrimaryKey, AutoIncrement]
	public int ID { get; set; }
	public string Description { get; set; }
	public DateTime Date { get; set; }
}
}
