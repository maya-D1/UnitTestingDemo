namespace MathLibrary;

/// <summary> 
/// ةطيسب ةيضاير لاود ىلع يوتحي. 
/// </summary> 
public static class Calculator
{
    /// <summary> 
    /// نيحيحص نيددع برض لصاح بسحت. 
    /// </summary> 
    /// <param name="a">لولأا ددعلا</param> 
    /// <param name="b">يناثلا ددعلا</param> 
    /// <returns>برضلا جتان</returns> 
    public static int Multiply(int a, int b)
    {
        return a * b;
    } 
        /// <summary>
    /// يحسب ناتج قسمة عددين صحيحين.
    /// </summary>
    public static int Divide(int a, int b)
    {
        return a / b; // في حالة b = 0 سيحدث استثناء
    }

    /// <summary>
    /// يتحقق مما إذا كان العدد زوجياً.
    /// </summary>
    public static bool IsEven(int a)
    {
        return a % 2 == 0;
    }
}
 
