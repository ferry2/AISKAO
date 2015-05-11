﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechnoLogica.Eservices.InformationObjects.Documents;
using System.ComponentModel.DataAnnotations;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;

namespace TechnoLogica.Eservices.InformationObjects
{
    public partial class CROZConsignmentRegistrationEntryData : IInformationObject
    {
        /// <summary>
        /// Връща истина, ако има дефинирани елементи в списъка. Резултатът показва дали стойността на свойството да бъде сериализирана в XML.
        /// </summary>
        /// <returns>Истина, ако има дефинирани елементи в списъка</returns>
        public bool ShouldSerializeCROZConsignmentRegistrationEntryParticipantDatas()
        {
            return !(this.CROZConsignmentRegistrationEntryParticipantDatas == null
                || this.CROZConsignmentRegistrationEntryParticipantDatas.Count <= 0);
        }

        /// <summary>
        /// Връща истина, ако има дефинирани елементи в списъка. Резултатът показва дали стойността на свойството да бъде сериализирана в XML.
        /// </summary>
        /// <returns>Истина, ако има дефинирани елементи в списъка</returns>
        public bool ShouldSerializeCROZRegistrationEntryDateForNewManagerInvitationsData()
        {
            return !(this.CROZRegistrationEntryDateForNewManagerInvitationsData == null
                || this.CROZRegistrationEntryDateForNewManagerInvitationsData.CROZRegistrationEntryCreationDates == null
                || this.CROZRegistrationEntryDateForNewManagerInvitationsData.CROZRegistrationEntryCreationDates.Count <= 0);
        }

    }
}
