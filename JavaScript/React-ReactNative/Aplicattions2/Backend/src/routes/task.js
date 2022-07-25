import {Router} from 'express';
import {deleteTask, getTask, getTaskCount, getTasks, saveTask, updateTask} from '../controllers/task '

const router = Router();
/** 
 * @swagger
 * tags:
 *  name: Tasks
 *  description: Tasks endpoint 
 */

/**
 * @swagger
 * /task:
 *  get:
 *      summary: Get all tasks
 *      tags: [Tasks]
 */
router.get('/task', getTask);
/** 
 * @swagger
 * /task/count:
 *  get:
 *   summary: Get how many tasks have
 *   tags: [Tasks]
 */
router.get('/task/count', getTaskCount);
/** 
 * @swagger
 * /task/:id:
 *   get:
 *      summary: Get some task for id
 *      tags: [Tasks]
 */
router.get('/task/:id', getTasks);
/** 
 * @swagger
 * /task:
 *  post:
 *      summary: Save a new task
 *      tags: [Tasks]
 *  */
router.post('/task',saveTask);
/** 
 * @swagger
 * /task/:id:
 *  delete:
 *      summary: Delete a task for id
 *      tags: [Tasks]
 *  */
router.delete('/task/:id', deleteTask);
/** 
 * @swagger
 * /task/:id:
 *  put:
 *      summary: Update a task for id
 *      tags: [Tasks]
 *  */
router.put('/task/:id', updateTask);

export default router