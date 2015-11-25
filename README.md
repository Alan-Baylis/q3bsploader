# Q3BSPLoader

A reasonably performant Quake 3 BSP loader in C#.

## Usage

```c#
var bsp = new Bsp("../Maps/Test.bsp");
```

## Example Output

```
Loaded ../Maps/Test.bsp in 76.2081ms
 * 69 textures
 * 5270 planes
 * 5807 nodes
 * 5816 leaves
 * 19601 leaf faces
 * 17881 leaf brushes
 * 8 models
 * 2599 brushes
 * 16769 brush sides
 * 29984 vertices
 * 24516 mesh vertices
 * 1 effects
 * 4206 faces
```

## License

Copyright (c) 2014 Kyle Kestell

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.  IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.