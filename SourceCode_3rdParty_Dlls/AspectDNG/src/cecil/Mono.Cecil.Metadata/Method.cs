//
// MethodTable.cs
//
// Author:
//   Jb Evain (jbevain@gmail.com)
//
// Generated by /CodeGen/cecil-gen.rb do not edit
// Thu May 18 16:14:43 CEST 2006
//
// (C) 2005 Jb Evain
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace Mono.Cecil.Metadata {

	using Mono.Cecil;

	using Mono.Cecil.Binary;

	public sealed class MethodTable : IMetadataTable {

		public const int RId = 0x06;

		RowCollection m_rows;

		public MethodRow this [int index] {
			get { return m_rows [index] as MethodRow; }
			set { m_rows [index] = value; }
		}

		public RowCollection Rows {
			get { return m_rows; }
			set { m_rows = value; }
		}

		public int Id {
			get { return RId; }
		}

		internal MethodTable ()
		{
		}

		public void Accept (IMetadataTableVisitor visitor)
		{
			visitor.VisitMethodTable (this);
			this.Rows.Accept (visitor.GetRowVisitor ());
		}
	}

	public sealed class MethodRow : IMetadataRow {

		public static readonly int RowSize = 20;
		public static readonly int RowColumns = 6;

		public RVA RVA;
		public MethodImplAttributes ImplFlags;
		public MethodAttributes Flags;
		public uint Name;
		public uint Signature;
		public uint ParamList;

		internal MethodRow ()
		{
		}

		public void Accept (IMetadataRowVisitor visitor)
		{
			visitor.VisitMethodRow (this);
		}
	}
}
