# Deslang

Deslang takes "Slang", which is a subset of C#6 and converts it to a CodeDOM tree, and then creates code to reconstruct that CodeDOM tree. That tree can then be analyzed, transformed or rendered in a language independent manner.


Note that this project helps build itself. As a result the executable is run from the root directory of the solution during build. If you don't trust this process, you can remove the prebuild step, and the deslang.exe from your project settings and solution folder.

See this article:
https://www.codeproject.com/Articles/5254092/Deslang-From-Code-to-CodeDOM-and-Back