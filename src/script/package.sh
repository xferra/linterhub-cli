dotnet restore src/cli/project.json && \
dotnet publish src/cli/project.json --output bin/$1/ -c release -r $1 && \
tar -czf bin/linterhub-cli-$1.tar.gz bin/$1 && \
rm -R bin/$1