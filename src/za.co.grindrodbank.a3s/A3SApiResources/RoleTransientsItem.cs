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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using za.co.grindrodbank.a3s.Converters;

namespace za.co.grindrodbank.a3s.A3SApiResources
{ 
    /// <summary>
    /// Represents a transient state of a role. 
    /// </summary>
    [DataContract]
    public partial class RoleTransientsItem : IEquatable<RoleTransientsItem>
    { 
        /// <summary>
        /// A unique ID for a transient role record.
        /// </summary>
        /// <value>A unique ID for a transient role record.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RState
        /// </summary>
        [DataMember(Name="r_state", EmitDefaultValue=false)]
        public string RState { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalCount
        /// </summary>
        [DataMember(Name="approvalCount", EmitDefaultValue=false)]
        public int ApprovalCount { get; set; }

        /// <summary>
        /// The required approval count before this entity is released.
        /// </summary>
        /// <value>The required approval count before this entity is released.</value>
        [DataMember(Name="requiredApprovalCount", EmitDefaultValue=false)]
        public Object RequiredApprovalCount { get; set; }

        /// <summary>
        /// Gets or Sets ChangedBy
        /// </summary>
        [DataMember(Name="changedBy", EmitDefaultValue=false)]
        public Guid ChangedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleTransientsItem {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RState: ").Append(RState).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ApprovalCount: ").Append(ApprovalCount).Append("\n");
            sb.Append("  RequiredApprovalCount: ").Append(RequiredApprovalCount).Append("\n");
            sb.Append("  ChangedBy: ").Append(ChangedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RoleTransientsItem)obj);
        }

        /// <summary>
        /// Returns true if RoleTransientsItem instances are equal
        /// </summary>
        /// <param name="other">Instance of RoleTransientsItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleTransientsItem other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Uuid == other.Uuid ||
                    Uuid != null &&
                    Uuid.Equals(other.Uuid)
                ) && 
                (
                    RoleId == other.RoleId ||
                    RoleId != null &&
                    RoleId.Equals(other.RoleId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    RState == other.RState ||
                    RState != null &&
                    RState.Equals(other.RState)
                ) && 
                (
                    Action == other.Action ||
                    Action != null &&
                    Action.Equals(other.Action)
                ) && 
                (
                    ApprovalCount == other.ApprovalCount ||
                    
                    ApprovalCount.Equals(other.ApprovalCount)
                ) && 
                (
                    RequiredApprovalCount == other.RequiredApprovalCount ||
                    RequiredApprovalCount != null &&
                    RequiredApprovalCount.Equals(other.RequiredApprovalCount)
                ) && 
                (
                    ChangedBy == other.ChangedBy ||
                    ChangedBy != null &&
                    ChangedBy.Equals(other.ChangedBy)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Uuid != null)
                    hashCode = hashCode * 59 + Uuid.GetHashCode();
                    if (RoleId != null)
                    hashCode = hashCode * 59 + RoleId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (RState != null)
                    hashCode = hashCode * 59 + RState.GetHashCode();
                    if (Action != null)
                    hashCode = hashCode * 59 + Action.GetHashCode();
                    
                    hashCode = hashCode * 59 + ApprovalCount.GetHashCode();
                    if (RequiredApprovalCount != null)
                    hashCode = hashCode * 59 + RequiredApprovalCount.GetHashCode();
                    if (ChangedBy != null)
                    hashCode = hashCode * 59 + ChangedBy.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RoleTransientsItem left, RoleTransientsItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RoleTransientsItem left, RoleTransientsItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}