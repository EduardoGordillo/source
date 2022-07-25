import express from 'express';
import cors from 'cors';
import morgan from 'morgan';
import swagggerJSDoc from 'swagger-jsdoc';
import swaggerUI from 'swagger-ui-express';
import {options} from './swaggerOptions';
const specs = swagggerJSDoc(options);

import taskRoute from './routes/task';

const app = express();

app.use(cors());
app.use(morgan("dev"))
app.use(express.json());
app.use(taskRoute);

app.use('/docs', swaggerUI.serve, swaggerUI.setup(specs));
export default app;