# RaspbianにMONOインストール

http://www.mono-project.com/download/stable/#download-lin-raspbian

```sh
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb http://download.mono-project.com/repo/debian stable-raspbianjessie main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
sudo apt-get update
```

```sh
$ sudo apt-get install mono-devel mono-complete mono-dbg referenceassemblies-pcl ca-certificates-mono  mono-xsp4 > /tmp/work/mono_install.log
```

* [インストールログ](mono_install.log)

