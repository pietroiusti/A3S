/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.1.3
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
    /// Models a terms of service agreement that needs to be agreed to by a user on login. Used to create or update a terms of service agreement. UUID is required when updating a terms of service agreement. Can be optionally associated with a sub-realm by specifying the &#39;subRealmId&#39; of the sub-realm. 
    /// </summary>
    [DataContract]
    public partial class TermsOfServiceSubmit : IEquatable<TermsOfServiceSubmit>
    { 
        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Gets or Sets AgreementName
        /// </summary>
        [Required]
        [DataMember(Name="agreementName", EmitDefaultValue=false)]
        public string AgreementName { get; set; }

        /// <summary>
        /// Gets or Sets AgreementFileData
        /// </summary>
        [Required]
        [DataMember(Name="agreementFileData", EmitDefaultValue=false)]
        public string AgreementFileData { get; set; }

        /// <summary>
        /// Gets or Sets AutoUpdate
        /// </summary>
        [Required]
        [DataMember(Name="autoUpdate", EmitDefaultValue=true)]
        public bool AutoUpdate { get; set; }

        /// <summary>
        /// The UUID identifier for a sub-realm.
        /// </summary>
        /// <value>The UUID identifier for a sub-realm.</value>
        [DataMember(Name="subRealmId", EmitDefaultValue=false)]
        public Guid SubRealmId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TermsOfServiceSubmit {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  AgreementName: ").Append(AgreementName).Append("\n");
            sb.Append("  AgreementFileData: ").Append(AgreementFileData).Append("\n");
            sb.Append("  AutoUpdate: ").Append(AutoUpdate).Append("\n");
            sb.Append("  SubRealmId: ").Append(SubRealmId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TermsOfServiceSubmit)obj);
        }

        /// <summary>
        /// Returns true if TermsOfServiceSubmit instances are equal
        /// </summary>
        /// <param name="other">Instance of TermsOfServiceSubmit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermsOfServiceSubmit other)
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
                    AgreementName == other.AgreementName ||
                    AgreementName != null &&
                    AgreementName.Equals(other.AgreementName)
                ) && 
                (
                    AgreementFileData == other.AgreementFileData ||
                    AgreementFileData != null &&
                    AgreementFileData.Equals(other.AgreementFileData)
                ) && 
                (
                    AutoUpdate == other.AutoUpdate ||
                    
                    AutoUpdate.Equals(other.AutoUpdate)
                ) && 
                (
                    SubRealmId == other.SubRealmId ||
                    SubRealmId != null &&
                    SubRealmId.Equals(other.SubRealmId)
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
                    if (AgreementName != null)
                    hashCode = hashCode * 59 + AgreementName.GetHashCode();
                    if (AgreementFileData != null)
                    hashCode = hashCode * 59 + AgreementFileData.GetHashCode();
                    
                    hashCode = hashCode * 59 + AutoUpdate.GetHashCode();
                    if (SubRealmId != null)
                    hashCode = hashCode * 59 + SubRealmId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TermsOfServiceSubmit left, TermsOfServiceSubmit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TermsOfServiceSubmit left, TermsOfServiceSubmit right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
