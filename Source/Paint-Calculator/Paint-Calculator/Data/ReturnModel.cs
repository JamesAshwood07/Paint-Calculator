namespace Paint_Calculator.Data
{
    // Return Model
    // Description: An object to store the data returned to the web page
    public class ReturnModel
    {
        // Volume (decimal): The volume of the room
        public decimal Volume { get; set; }

        // FloorArea (decimal): The area of the floor
        public decimal FloorArea { get; set; }

        // PaintRequired (decimal): The paint required for the room
        public decimal PaintRequired { get; set; }
    }
}
