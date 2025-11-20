using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Collection.Abstractions;

public interface ICollectionProperties : IDataLocationItem, IDataDictionary<String64, ICollectionProperty>;