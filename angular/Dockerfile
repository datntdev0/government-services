ARG BUILD_ENV="production"

# stage 1
FROM node:20 as node
ARG BUILD_ENV

WORKDIR /app
COPY . .
RUN yarn install
RUN yarn run ng build --configuration $BUILD_ENV

# stage 2
FROM nginx

COPY --from=node /app/dist /usr/share/nginx/html
COPY fast-nginx-default.conf /etc/nginx/conf.d/default.conf
