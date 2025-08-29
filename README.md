> [!IMPORTANT]
> **Data.HashFunction has been superseded by [HashifyNET](https://github.com/Deskasoft/HashifyNET), the next version of Data.HashFunction.**
> **Please switch to [HashifyNET](https://github.com/Deskasoft/HashifyNET) for additional features and continuous support for security and bug fixes.**

--------------------------------------------------------------------------------------------------------
<br>
<br>
<img src="https://github.com/user-attachments/assets/fc94c7e0-96c6-4dfd-a728-0fd15656b5a4">

Data.HashFunction ![License](https://img.shields.io/github/license/brandondahler/Data.HashFunction.svg)
=================

**This project was originally maintained at [brandondahler/Data.HashFunction](https://github.com/brandondahler/Data.HashFunction) before 05/11/2022 (PT). It is maintained by Deskasoft International since then.**
Join our Discord at https://discord.gg/PrKery9 to discuss about our projects.

Data.HashFunction is a C# library to create a common interface to [non-cryptographic hash functions](http://en.wikipedia.org/wiki/List_of_hash_functions#Non-cryptographic_hash_functions) and provide implementations of public hash functions.  It is licensed under the permissive and OSI approved [MIT](http://opensource.org/licenses/MIT) license.


All functionality of the library is tested using [xUnit](https://github.com/xunit/xunit).  A primary requirement for each release is 100% code coverage by these tests.

All code within the libarary is commented using Visual Studio-compatible XML comments.

## Documentation Page
The new documentation page is available at [https://deskasoft.dev/projects/data.hashfunction/](https://deskasoft.dev/projects/data.hashfunction/).

Status
------

### Master

[![Build Status](https://img.shields.io/appveyor/ci/LordOfXen/data-hashfunction/master.svg)](https://ci.appveyor.com/project/LordOfXen/data-hashfunction)


### NuGet

| Name                            | Normal                                                                                                                                                                 |
|---------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Data.HashFunction.BernsteinHash | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.BernsteinHash.svg)](https://www.nuget.org/packages/Data.HashFunction.BernsteinHash/) |
| Data.HashFunction.Blake2        | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.Blake2.svg)](https://www.nuget.org/packages/Data.HashFunction.Blake2/)               |
| Data.HashFunction.Blake3        | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.Blake3.svg)](https://www.nuget.org/packages/Data.HashFunction.Blake3/)               |
| Data.HashFunction.BuzHash       | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.Buzhash.svg)](https://www.nuget.org/packages/Data.HashFunction.Buzhash/)             |
| Data.HashFunction.CityHash      | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.CityHash.svg)](https://www.nuget.org/packages/Data.HashFunction.CityHash/)           |
| Data.HashFunction.CRC           | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.CRC.svg)](https://www.nuget.org/packages/Data.HashFunction.CRC/)                     |
| Data.HashFunction.ELF64         | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.ELF64.svg)](https://www.nuget.org/packages/Data.HashFunction.ELF64/)                 |
| Data.HashFunction.FNV           | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.FNV.svg)](https://www.nuget.org/packages/Data.HashFunction.FNV/)                     |
| Data.HashFunction.HashAlgorithm | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.HashAlgorithm.svg)](https://www.nuget.org/packages/Data.HashFunction.HashAlgorithm/) |
| Data.HashFunction.Jenkins       | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.Jenkins.svg)](https://www.nuget.org/packages/Data.HashFunction.Jenkins/)             |
| Data.HashFunction.MurmurHash    | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.MurmurHash.svg)](https://www.nuget.org/packages/Data.HashFunction.MurmurHash/)       |
| Data.HashFunction.Pearson       | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.Pearson.svg)](https://www.nuget.org/packages/Data.HashFunction.Pearson/)             |
| Data.HashFunction.SpookyHash    | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.SpookyHash.svg)](https://www.nuget.org/packages/Data.HashFunction.SpookyHash/)       |
| Data.HashFunction.xxHash        | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.xxHash.svg)](https://www.nuget.org/packages/Data.HashFunction.xxHash/)               |

There is also a nuget package referencing all available hash functions, which you can find below. Use this to easily bind all hash functions to your project.

| Name                            | Normal                                                                                                                                                                 |
|---------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Data.HashFunction        | [![Version Status](https://img.shields.io/nuget/v/Data.HashFunction.svg)](https://www.nuget.org/packages/Data.HashFunction/)               |

Implementations
---------------

All implementation packages depend on the Data.HashFunction.Interfaces and Data.HashFunction.Core NuGet packages.

The following hash functions have been implemented from the most reliable reference that could be found.

* [Bernstein Hash](http://www.eternallyconfuzzled.com/tuts/algorithms/jsw_tut_hashing.aspx#djb)
  * BernsteinHash - Original
  * ModifiedBernsteinHash - Minor update that is said to result in better distribution
* [Blake2](https://blake2.net/)
  * Blake2b
* [Blake3](https://en.wikipedia.org/wiki/BLAKE_(hash_function)#BLAKE3)
  * Blake3 (through https://github.com/xoofx/Blake3.NET - does not require the mentioned project)
* [BuzHash](http://www.serve.net/buz/hash.adt/java.002.html)
  * BuzHashBase - Abstract implementation, there is no authoritative implementation
  * DefaultBuzHash - Concrete implementation, uses 256 random 64-bit integers
* [CityHash](https://code.google.com/p/cityhash/)
* [CRC](http://en.wikipedia.org/wiki/Cyclic_redundancy_check)
  * CRC - Generalized implementation to allow any CRC parameters between 1 and 64 bits.
  * CRCStandards - 71 implementations on top of CRC that use the parameters defined by their respective standard.  Standards and their parameters provided by [CRC RevEng's catalogue](http://reveng.sourceforge.net/crc-catalogue/).
* [ELF64](http://downloads.openwatcom.org/ftp/devel/docs/elf-64-gen.pdf)
* [FNV](http://www.isthe.com/chongo/tech/comp/fnv/index.html)
  * FNV1Base - Abstract base of the FNV-1 algorithms
  * FNV1 - Original
  * FNV1a - Minor variation of FNV-1
* [Hash Algorithm Wrapper](http://msdn.microsoft.com/en-us/library/system.security.cryptography.hashalgorithm%28v=vs.110%29.aspx)
  * HashAlgorithmWrapper - Wraps existing instance of a .Net HashAlgorithm
  * HashAlgorithmWrapper<HashAlgorithmT> - Wraps a managed instance of a .Net HashAlgorithm
* [Jenkins](http://en.wikipedia.org/wiki/Jenkins_hash_function)
  * JenkinsOneAtATime - Original
  * JenkinsLookup2 - Improvement upon One-at-a-Time hash function
  * JenkinsLookup3 - Further improvement upon Jenkins' Lookup2 hash function
* [Murmur Hash](https://code.google.com/p/smhasher/wiki/MurmurHash)
  * MurmurHash1 - Original
  * MurmurHash2 - Improvement upon MurmurHash1
  * MurmurHash3 - Further improvement upon MurmurHash2, addresses minor flaws
* [Pearson hashing](http://en.wikipedia.org/wiki/Pearson_hashing)
  * PearsonBase - Abstract implementation, there is no authoritative implementation
  * WikipediaPearson - Concrete implementation, uses values from Wikipedia article
* [SpookyHash](http://burtleburtle.net/bob/hash/spooky.html)
  * SpookyHashV1 - Original
  * SpookyHashV2 - Improvement upon SpookyHashV1, fixes bug in original specification
* [xxHash](https://code.google.com/p/xxhash/)
  * xxHash - Original and 64-bit version.


Each family of hash functions is contained within its own project and NuGet package.


Usage
-----

The usage for all hash functions has been standardized and is accessible via the System.Data.HashFunction.IHashFunction and System.Data.HashFunction.IHashFunctionAsync interfaces.  The core package, Data.HashFunction.Core, only contains abstract hash function implementations and base functionality for the library.  In order to use a specific hashing algorithms, you will need to reference its implementation packages.

IHashFunction implementations should be immutable and stateles.  All IHashFunction methods and members should be thread safe.

``` C#
using System;
using System.Data.HashFunction;
using System.Data.HashFunction.Jenkins;

public class Program
{
    public static readonly IJenkinsOneAtATime _jenkinsOneAtATime = JenkinsOneAtATimeFactory.Instance.Create();
    public static void Main()
    {
        var hashValue = _jenkinsOneAtATime.ComputeHash("foobar");

        Console.WriteLine(hashValue.AsHexString());
    }
}
```



Release Notes
-------------
See [Release Notes](https://github.com/Deskasoft/Data.HashFunction/wiki/Release-Notes) wiki page.

## Versioning Guarantees

This library generally abides by [Semantic Versioning](https://semver.org). Packages are published in `MAJOR.MINOR.PATCH` version format.

### Patch component

An increment of the **PATCH** component always indicates that an internal-only change was made, generally a bug fix. These changes will not affect the public-facing API in any way, and are always guaranteed to be forward/backwards-compatible with your codebase, any pre-compiled dependencies of your codebase.

### Minor component

An increment of the **MINOR** component indicates that some addition was made to the library,
and this addition **may not be** backwards-compatible with prior versions.

### Major component

An increment of the **MAJOR** component indicates that breaking changes have been made to the library;
**consumers should check the release notes to determine what changes need to be made.**


Contributing
------------

Feel free to propose changes, notify of issues, or contribute code using GitHub!  Submit issues and/or pull requests as necessary. 

There are no special requirements for change proposal or issue notifications.  


Code contributions should follow existing code's methodologies and style, along with XML comments for all public and protected namespaces, classes, and functions added.


License
-------

Data.HashFunction is released under the terms of the MIT license. See [LICENSE](https://github.com/deskasoft/Data.HashFunction/blob/master/LICENSE) for more information or see http://opensource.org/licenses/MIT.
