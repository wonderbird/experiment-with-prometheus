FROM ubuntu

# see https://docs.docker.com/develop/develop-images/dockerfile_best-practices/
RUN apt-get update && \
    apt-get install -y \
      curl \
    && rm -rf /var/lib/apt/lists/*

ENTRYPOINT ["/usr/bin/tail", "-f", "/dev/null"]
