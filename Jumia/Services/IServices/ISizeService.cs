﻿using Jumia.Models;

namespace Jumia.Services.IServices
{
    public interface ISizeService
    {
        public Task<List<Size>> GetSizesByProduct(int productId);
        
        public Task<List<Size>> GetSizesByColor(int productId, int colorId);

    }
}
