﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if !STRONG_NAME
    [assembly: InternalsVisibleTo("System.Data.HashFunction.BernsteinHash.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Blake2.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.BuzHash.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.CityHash.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.CRC.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.ELF64.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.FNV.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Jenkins.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.MurmurHash.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Pearson.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.SpookyHash.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Test.Net40Async")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.xxHash.Net40Async")]
#else
    [assembly: InternalsVisibleTo("System.Data.HashFunction.BernsteinHash.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Blake2.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.BuzHash.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.CityHash.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.CRC.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.ELF64.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.FNV.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Jenkins.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.MurmurHash.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Pearson.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.SpookyHash.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Test.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.xxHash.Net40Async, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
#endif

