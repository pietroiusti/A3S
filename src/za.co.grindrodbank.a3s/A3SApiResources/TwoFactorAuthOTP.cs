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
 * The version of the OpenAPI document: 2.0.0-alpha-1.0.0
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
    /// A OTP for a specific user. 
    /// </summary>
    [DataContract]
    public partial class TwoFactorAuthOTP : IEquatable<TwoFactorAuthOTP>
    { 
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets OTP
        /// </summary>
        [DataMember(Name="OTP", EmitDefaultValue=false)]
        public string OTP { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TwoFactorAuthOTP {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  OTP: ").Append(OTP).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TwoFactorAuthOTP)obj);
        }

        /// <summary>
        /// Returns true if TwoFactorAuthOTP instances are equal
        /// </summary>
        /// <param name="other">Instance of TwoFactorAuthOTP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwoFactorAuthOTP other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    OTP == other.OTP ||
                    OTP != null &&
                    OTP.Equals(other.OTP)
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
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (OTP != null)
                    hashCode = hashCode * 59 + OTP.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TwoFactorAuthOTP left, TwoFactorAuthOTP right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TwoFactorAuthOTP left, TwoFactorAuthOTP right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
