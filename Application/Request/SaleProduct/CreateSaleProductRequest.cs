﻿namespace Application.Request;

public class CreateSaleProductRequest
{   
    public int SaleId {get;set;}
    public Guid ProductId {get;set;}
    public int Quantity {get;set;}
    public decimal Price {get;set;}
    public int Discount {get;set;}
}
