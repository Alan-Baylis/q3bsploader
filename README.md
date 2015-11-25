# Q3BSPLoader

A reasonably performant Quake 3 BSP loader in C#.

## Usage

```c#
var bsp = new Bsp("test.bsp");
```

## Example Output

```
Loaded test.bsp in 89.9873ms
  * 37 textures
  * 5600 planes
  * 4214 nodes
  * 4228 leaves
  * 12186 leaf faces
  * 7684 leaf brushes
  * 13 models
  * 1900 brushes
  * 13483 brush sides
  * 32892 vertices
  * 68307 mesh vertices
  * 1 effects
  * 5969 faces
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