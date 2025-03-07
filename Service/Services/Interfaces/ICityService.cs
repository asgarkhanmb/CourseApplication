﻿using Service.DTOs.Admin.Cities;
using Service.DTOs.Admin.Countries;
using Service.DTOs.Admin.Groups;

namespace Service.Services.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<CityDto>> GetAllAsync();
        Task<CityDto> GetByIdAsync(int id);
        Task<CityDto> GetByNameAsync(string name);
        Task CreateAsync(CityCreateDto model);
        Task<IEnumerable<CityDto>> FilterAsync(string name, string countryName);
        Task DeleteAsync(int? id);
        Task EditAsync(int? id, CityEditDto model);
    }
}
