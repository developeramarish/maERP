﻿using System.Linq.Dynamic.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using maERP.Application.Contracts.Logging;
using maERP.Application.Contracts.Persistence;
using maERP.Application.Extensions;
using maERP.Application.Specifications;
using maERP.Domain.Dtos.TaxClass;
using maERP.Domain.Wrapper;
using MediatR;

namespace maERP.Application.Features.TaxClass.Queries.TaxClassList;

public class TaxClassListHandler : IRequestHandler<TaxClassListQuery, PaginatedResult<TaxClassListDto>>
{
    private readonly IMapper _mapper;
    private readonly IAppLogger<TaxClassListHandler> _logger;
    private readonly ITaxClassRepository _taxClassRepository;

    public TaxClassListHandler(IMapper mapper,
        IAppLogger<TaxClassListHandler> logger, 
        ITaxClassRepository taxClassRepository)
    {
        _mapper = mapper;
        _logger = logger;
        _taxClassRepository = taxClassRepository; 
    }
    public async Task<PaginatedResult<TaxClassListDto>> Handle(TaxClassListQuery request, CancellationToken cancellationToken)
    {
        var taxClassFilterSpec = new TaxClassFilterSpecification(request.SearchString);
        
        _logger.LogInformation("Handle TaxClassListQuery: {0}", request);

        if (request.OrderBy.Any() != true)
        {
            return await _taxClassRepository.Entities
               .Specify(taxClassFilterSpec)
               .ProjectTo<TaxClassListDto>(_mapper.ConfigurationProvider)
               .ToPaginatedListAsync(request.PageNumber, request.PageSize);
        }

        var ordering = string.Join(",", request.OrderBy);

        return await _taxClassRepository.Entities
            .Specify(taxClassFilterSpec)
            .OrderBy(ordering)
            .ProjectTo<TaxClassListDto>(_mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber, request.PageSize);
    }
}