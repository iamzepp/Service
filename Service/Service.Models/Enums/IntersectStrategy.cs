namespace Service.Models.Enums
{
    /// <summary>
    /// Стратегия пересечения
    /// </summary>
    public enum IntersectStrategy
    {
        /// <summary>
        /// Строго уникальная 
        /// </summary>
        UNIQUE = 1,
        
        /// <summary>
        /// По идентификатору
        /// </summary>
        BYID = 2
    }
}