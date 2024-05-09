﻿using Domain.Entities;

namespace Application.Interfaces;

public interface IProductQuery
{
    Task<List<Product>> GetListProducts(string name, int offset, int limit);
    Task<Product> GetProductById(Guid productId);
}
