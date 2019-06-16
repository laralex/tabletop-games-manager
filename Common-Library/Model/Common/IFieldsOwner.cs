using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.Common
{
    /// <summary>
    /// This object has controls, which are user input fields 
    /// When they're are filled right or wrong, some event are Invoked
    /// </summary>
    public interface IFieldsOwner : IResetable
    {
        /// <summary>
        /// Returns true, when crucial fields are filled with data
        /// </summary>
        bool FieldsFilled { get; }
        /// <summary>
        /// Is invoked, when form is complete
        /// </summary>
        event EventHandler FieldsFilledEvent;
        /// <summary>
        /// Is invoked, when form is not complete
        /// </summary>
        event EventHandler FieldsNotFilledEvent;
    }
}
