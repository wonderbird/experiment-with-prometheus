# Experiment with Prometheus

Experimenting with prometheus and its ecosystem.

This project shows how to run a prometheus server, connect it to grafana and add some services for scraping metrics.

The software in this project is highly experimental. Its only purpose is for me to learn about prometheus and grafana features and integrating them into a docker-compose / kubernetes environment.

## Usage

Running `docker-compose up` in this directory will build the container images and startup the system.

Once the system is running you can...

* Connect to Prometheus on http://localhost:9090
  * In Prometheus you can view all the names of all scraped metrics
* Connect to Grafana on http://localhost:3000 (username "admin" and password "admin")
  * In Grafana you can add a new data source and select "Prometheus". The URL is "http://prometheus:9090".
* Enter the ubuntu-analysis-helper container to query the other containers in the network:
  * `docker exec -it ubuntu-analysis-helper /bin/bash`
  * `root@...:/# curl sample-metrics-generator/metrics`

## References

* https://prometheus.io (you can run the tutorial including Grafana with the setup presented here)
* https://grafana.com
