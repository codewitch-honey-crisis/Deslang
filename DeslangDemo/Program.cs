using System;
using System.CodeDom;

using CD;
namespace DeslangDemo
{
	class Program
	{
		static void Main(string[] args) {
			var widget = Deslanged.Widget;
			CD.CodeDomVisitor.Visit(widget, (CodeDomVisitContext ctx) => {
				var cmr = ctx.Target as CodeMethodReturnStatement;
				if (cmr != null)
				{
					var cpe = cmr.Expression as CodePrimitiveExpression;
					if(cpe != null)
					{
						if ((cpe.Value as string) == "$marker")
						{
							cpe.Value = "Hello World!";
							ctx.Cancel = true;
						}
					}
				}
			},CodeDomVisitTargets.All);
			Console.WriteLine(CD.CodeDomUtility.ToString(widget));
		}
	}
}