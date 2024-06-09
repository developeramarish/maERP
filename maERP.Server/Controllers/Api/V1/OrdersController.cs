﻿using Asp.Versioning;
using maERP.Application.Features.Order.Commands.CreateOrder;
using maERP.Application.Features.Order.Commands.DeleteOrder;
using maERP.Application.Features.Order.Commands.UpdateOrder;
using maERP.Application.Features.Order.Queries.GetOrderDetail;
using maERP.Application.Features.Order.Queries.GetOrders;
using maERP.Shared.Wrapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace maERP.Server.Controllers.Api.V1;

[ApiController]
[Authorize]
[ApiVersion(1.0)]
[Route("/api/v{version:apiVersion}/[controller]")]
public class OrdersController(IMediator mediator) : ControllerBase
{
    // GET: api/<OrdersController>
    [HttpGet]
    public async Task<ActionResult<PaginatedResult<GetOrdersResponse>>> GetAll(int pageNumber = 1, int pageSize = 10, string searchString = "", string orderBy = "")
    {
        if (string.IsNullOrEmpty(orderBy))
        {
            orderBy = "DateOrdered Descending";
        }

        var orders = await mediator.Send(new GetOrdersQuery(pageNumber, pageSize, searchString, orderBy));
        return Ok(orders);
    }

    // GET api/<OrdersController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<GetOrderDetailResponse>> GetDetails(int id)
    {
        var order = await mediator.Send(new GetOrderDetailQuery { Id = id });
        return Ok(order);
    }

    // POST api/<OrdersController>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<int>> Create(CreateOrderCommand createOrderCommand)
    {
        var response = await mediator.Send(createOrderCommand);
        return CreatedAtAction(nameof(GetDetails), new { id = response });
    }

    // PUT: api/<OrdersController>/5
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Update(int id, UpdateOrderCommand updateOrderCommand)
    {
        updateOrderCommand.Id = id;
        await mediator.Send(updateOrderCommand);
        return NoContent();
    }

    // DELETE api/<OrderController>/5
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(int id)
    {
        var command = new DeleteOrderCommand { Id = id };
        await mediator.Send(command);
        return NoContent();
    }
}