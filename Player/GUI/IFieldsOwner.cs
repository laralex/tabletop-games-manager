using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Player.GUI
{
    // This object has controls, which are user input fields
    interface IFieldsOwner
    {
        // Rollback all fields to initial state
        void ResetFields();

        // Returns true, when crucial fields are filled with data
        bool FieldsFilled { get; }
        // Is invoked, when form is complete
        event EventHandler FieldsFilledEvent;
        // Is invoked, when form is not complete
        event EventHandler FieldsNotFilledEvent;
    }
}
