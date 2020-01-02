FROM golang
ADD ./client_golang /go/src/client_golang
RUN cd /go/src/client_golang/examples/random && \
    go get -d && \
    go build
ENTRYPOINT ["/go/src/client_golang/examples/random/random", "-listen-address=:8080"]
EXPOSE 8080

