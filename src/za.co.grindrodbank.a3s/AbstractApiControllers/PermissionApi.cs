/**
 * *************************************************
 * Copyright (c) 2020, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.1.6
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
    public abstract class PermissionApiController : ControllerBase
    { 
        /// <summary>
        /// Get a permission.
        /// </summary>
        /// <remarks>Get a permission by its UUID.</remarks>
        /// <param name="permissionId">permission</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the permission.</response>
        /// <response code="404">Permission not found.</response>
        /// <response code="500">An unexpected error occurred</response>
        [HttpGet]
        [Route("/permissions/{permissionId}", Name = "GetPermission")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Permission))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> GetPermissionAsync([FromRoute][Required]Guid permissionId);

        /// <summary>
        /// Search for permissions.
        /// </summary>
        /// <remarks>Search for permissions.</remarks>
        /// <param name="page">The page to view.</param>
        /// <param name="size">The size of a page.</param>
        /// <param name="filterName">A search query filter on the permission&#39;s name.</param>
        /// <param name="orderBy">a comma separated list of fields in their sort order. Ascending order is assumed. Append &#39;_desc&#39; after a field to indicate descending order. Supported fields. &#39;name&#39;.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the list of permissions.</response>
        /// <response code="404">Permission list not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/permissions", Name = "ListPermissions")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<Permission>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> ListPermissionsAsync([FromQuery]int page, [FromQuery][Range(1, 20)]int size, [FromQuery][StringLength(255, MinimumLength=0)]string filterName, [FromQuery]string orderBy);
    }
}
