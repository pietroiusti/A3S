/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for the A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 0.2.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using za.co.grindrodbank.a3s.Attributes;
using Microsoft.AspNetCore.Authorization;
using za.co.grindrodbank.a3s.A3SApiResources;

namespace za.co.grindrodbank.a3s.AbstractApiControllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class RoleApiController : ControllerBase
    { 
        /// <summary>
        /// Create a Role.
        /// </summary>
        /// <remarks>Create a new Role.</remarks>
        /// <param name="roleSubmit"></param>
        /// <response code="200">Successful. Role created.</response>
        /// <response code="400">Invalid parameters.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - Not authorized to create a Role.</response>
        /// <response code="404">Role related entity not found.</response>
        /// <response code="422">Non-Processible Entity. The request was correctly structured, but some business rules were violated, preventing the creation of the role.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPost]
        [Route("/roles")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(RoleSubmit))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> CreateRoleAsync([FromBody]RoleSubmit roleSubmit);

        /// <summary>
        /// Get a role.
        /// </summary>
        /// <remarks>Get a role by its UUID.</remarks>
        /// <param name="roleId">The UUID of the role.</param>
        /// <response code="200">OK.</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access this role.</response>
        /// <response code="404">Role not found.</response>
        /// <response code="500">An unexpected error occurred</response>
        [HttpGet]
        [Route("/roles/{roleId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Role))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> GetRoleAsync([FromRoute][Required]Guid roleId);

        /// <summary>
        /// Search for Roles.
        /// </summary>
        /// <remarks>Search for Roles.</remarks>
        /// <param name="users">Whether to fill in the users member field</param>
        /// <param name="page">The page to view.</param>
        /// <param name="size">The size of a page.</param>
        /// <param name="filterDescription">A search query filter on the role&#39;s description.</param>
        /// <param name="orderBy">a comma separated list of fields in their sort order. Ascending order is assumed. Append desc after a field to indicate descending order.</param>
        /// <response code="200">OK.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the list of roles.</response>
        /// <response code="404">Roles list not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/roles")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<Role>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> ListRolesAsync([FromQuery]bool users, [FromQuery]int page, [FromQuery][Range(1, 20)]int size, [FromQuery][StringLength(255, MinimumLength=0)]string filterDescription, [FromQuery]List<string> orderBy);

        /// <summary>
        /// Update a role.
        /// </summary>
        /// <remarks>Update a role by its UUID.</remarks>
        /// <param name="roleId">The UUID of the role.</param>
        /// <param name="roleSubmit"></param>
        /// <response code="200">OK.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to update a role.</response>
        /// <response code="404">Role related entity not found.</response>
        /// <response code="422">Non-Processible Entity. The request was correctly structured, but some business rules were violated, preventing the updating of the role.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPut]
        [Route("/roles/{roleId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Role))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> UpdateRoleAsync([FromRoute][Required]Guid roleId, [FromBody]RoleSubmit roleSubmit);
    }
}
