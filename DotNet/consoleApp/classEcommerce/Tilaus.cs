using System;

public class Tilaus
{
    public DateTime Date { get; set; }

    public string ProductName { get; set; }

	public Asiakas Customer { get; set; }

    public int Amount { get; set; }
}