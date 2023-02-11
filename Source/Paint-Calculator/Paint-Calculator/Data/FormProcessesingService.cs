using System;
using System.Linq;
using System.Threading.Tasks;

namespace Paint_Calculator.Data
{
    public class FormProcessesingService
    {

        // Process Form
        // Returns: ReturnModel - A return model object with calculated data inside
        // Parameters: Model (FormModel) - The form data entered by the user
        // Description: Does the behind the scene calculations, including volume, floor area and paint required.
        public ReturnModel ProcessForm(FormModel Model)
        {
            decimal Volume = Model.Height * Model.Width * Model.Length;     // Calculate the volume by doing length by width by height
            decimal FloorArea = Model.Width * Model.Length;     // Calculate floor area by doing width by length
            decimal SurfaceArea = (2 * Model.Width * Model.Height) + (2 * Model.Height * Model.Length);     // Calculate surface area for the paint by calculating the area of each of the walls. Note: we ignore the ceiling and the floor 
            decimal PaintRequired = SurfaceArea * (decimal)0.1; // 10m^2 of surface requires 1 litre of paint, hence 0.1 litre per metre, hence times by 0.1

            ReturnModel returnData = new(); // Generate a new return data object based on the return model
            returnData.Volume = Volume;     // Assign its volume
            returnData.FloorArea = FloorArea;       // Assign its floor area
            returnData.PaintRequired = PaintRequired;       // Assign its paint required
            
            return returnData;      // Return the data
        }
    }
}