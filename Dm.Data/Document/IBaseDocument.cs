using System;

namespace Dm.Data.Document {
	public interface IBaseDocument {
		string Number { get; }
		DateTime Date { get; }
		Guid? ClassifyId { get; }
		Guid? SourceId { get; }
		DocumentType TypeId { get; }
		byte[] Body { get; }
		FileContentType BodyType { get; }
		string Name { get; }
	}
}