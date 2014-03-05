using System;

namespace Migrator.Framework
{    
    
    /// <summary>
    /// Represents a table column properties.
    /// </summary>
    [Flags]
    public enum ColumnProperty
    {
        None = 0,
        /// <summary>
        /// Null is allowable
        /// </summary>
        Null = 1,
        /// <summary>
        /// Null is not allowable
        /// </summary>
        NotNull = 2,
        /// <summary>
        /// Identity column, autoinc
        /// </summary>
        Identity = 4,
        /// <summary>
        /// Unique Column
        /// </summary>
        Unique = 8,
        /// <summary>
        /// Indexed Column
        /// </summary>
        Indexed = 16,
        /// <summary>
        /// Unsigned Column
        /// </summary>
        Unsigned = 32,
        PrimaryKeyBase = 64,
        /// <summary>
        /// Foreign Key
        /// </summary>
        ForeignKey = Unsigned | Null,
        /// <summary>
        /// Primary Key
        /// </summary>
        PrimaryKey = PrimaryKeyBase | Unsigned | NotNull,
        /// <summary>
        /// Primary key. Make the column a PrimaryKey and unsigned
        /// </summary>
        PrimaryKeyWithIdentity = PrimaryKey | Identity
    }
}
