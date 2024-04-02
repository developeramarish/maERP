﻿using AutoMapper;
using maERP.Application.Contracts.Persistence;
using MediatR;

namespace maERP.Application.Features.Warehouse.Queries.GetAllWarehouses;

public class GetAllWarehousesQueryHandler : IRequestHandler<GetAllWarehousesQuery, List<WarehouseListDto>>
{
    private readonly IMapper _mapper;
    private readonly IWarehouseRepository _warehouseRepository;

    public GetAllWarehousesQueryHandler(IMapper mapper, IWarehouseRepository warehouseRepository)
    {
        _mapper = mapper;
        _warehouseRepository = warehouseRepository; 
    }
    public async Task<List<WarehouseListDto>> Handle(GetAllWarehousesQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var warehouses = await _warehouseRepository.GetAllAsync();

        // Convert data objects to DTO objects
        var data = _mapper.Map<List<WarehouseListDto>>(warehouses);

        // Return list of DTO objects
        return data;
    }
}