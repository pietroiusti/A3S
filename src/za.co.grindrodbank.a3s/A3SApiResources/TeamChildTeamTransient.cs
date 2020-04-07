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
    /// Represents a transient state of a team child-team assignment. 
    /// </summary>
    [DataContract]
    public partial class TeamChildTeamTransient : IEquatable<TeamChildTeamTransient>
    { 
        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public Guid TeamId { get; set; }

        /// <summary>
        /// Gets or Sets ChildTeamId
        /// </summary>
        [DataMember(Name="childTeamId", EmitDefaultValue=false)]
        public Guid ChildTeamId { get; set; }

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
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamChildTeamTransient {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  ChildTeamId: ").Append(ChildTeamId).Append("\n");
            sb.Append("  RState: ").Append(RState).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ApprovalCount: ").Append(ApprovalCount).Append("\n");
            sb.Append("  RequiredApprovalCount: ").Append(RequiredApprovalCount).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TeamChildTeamTransient)obj);
        }

        /// <summary>
        /// Returns true if TeamChildTeamTransient instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamChildTeamTransient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamChildTeamTransient other)
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
                    TeamId == other.TeamId ||
                    TeamId != null &&
                    TeamId.Equals(other.TeamId)
                ) && 
                (
                    ChildTeamId == other.ChildTeamId ||
                    ChildTeamId != null &&
                    ChildTeamId.Equals(other.ChildTeamId)
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
                    CreatedBy == other.CreatedBy ||
                    CreatedBy != null &&
                    CreatedBy.Equals(other.CreatedBy)
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
                    if (TeamId != null)
                    hashCode = hashCode * 59 + TeamId.GetHashCode();
                    if (ChildTeamId != null)
                    hashCode = hashCode * 59 + ChildTeamId.GetHashCode();
                    if (RState != null)
                    hashCode = hashCode * 59 + RState.GetHashCode();
                    if (Action != null)
                    hashCode = hashCode * 59 + Action.GetHashCode();
                    
                    hashCode = hashCode * 59 + ApprovalCount.GetHashCode();
                    if (RequiredApprovalCount != null)
                    hashCode = hashCode * 59 + RequiredApprovalCount.GetHashCode();
                    if (CreatedBy != null)
                    hashCode = hashCode * 59 + CreatedBy.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TeamChildTeamTransient left, TeamChildTeamTransient right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TeamChildTeamTransient left, TeamChildTeamTransient right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
