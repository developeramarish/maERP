﻿namespace maERP.Shared.Dtos.TaxClass;

public class TaxClassBaseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double TaxRate { get; set; }
}