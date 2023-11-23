using CD;
using System;
using System.CodeDom;

namespace DeslangDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var widget = Deslanged.Widget;
			CodeDomVisitor.Visit(widget, (ctx) =>
			{
				// look for our marked primitive expression
				var cpe = ctx.Target as CodePrimitiveExpression;
				
				if(null!=cpe && "$marker"==(cpe.Value as string))
				{
					cpe.Value = "Hello world!";
					ctx.Cancel = true;
				}
			});

			Console.WriteLine(CodeDomUtility.ToString(widget));
		}
	}
}
