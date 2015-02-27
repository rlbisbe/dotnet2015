# We will use an existing image based on the
# verson 3.10 of Mono.
# This will be automatically retrieved from the Docker Hub.
# Docker Hub is Dockers community repository of pre-built containers
FROM mono:3.10
# Ensure everything is up to date on the machine and install unzip
RUN apt-get -qq update && apt-get -qqy install unzip
# Install ASP.NET vNext and latest K Runtime Environment (KRE)
RUN curl -s https://raw.githubusercontent.com/aspnet/Home/master/kvminstall.sh | sh
RUN bash -c "source /root/.k/kvm/kvm.sh \
      && kvm upgrade \
      && kvm alias default | xargs -i ln -s /root/.k/runtimes/{} /root/.k/runtimes/default"
# "ENV" sets an environment variable which will be set
# whenever the container is started

# Install libuv for Kestrel from source code (binary is not in wheezy and one in jessie is still too old)
RUN apt-get -qqy install \  
    autoconf \
    automake \
    build-essential \
    libtool
RUN LIBUV_VERSION=1.1.0 \  
    && curl -sSL https://github.com/libuv/libuv/archive/v${LIBUV_VERSION}.tar.gz | tar zxfv - -C /usr/local/src \
    && cd /usr/local/src/libuv-$LIBUV_VERSION \
    && sh autogen.sh && ./configure && make && make install \
    && cd / \
    && rm -rf /usr/local/src/libuv-$LIBUV_VERSION \
    && ldconfig

ENV PATH $PATH:/root/.k/runtimes/default/bin
